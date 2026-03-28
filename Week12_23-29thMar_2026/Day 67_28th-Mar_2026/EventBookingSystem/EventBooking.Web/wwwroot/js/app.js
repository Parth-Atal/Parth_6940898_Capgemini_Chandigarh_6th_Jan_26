const API_BASE = "http://localhost:5297/api"; // Change to your API port

// ── Auth Helpers ──────────────────────────────────────────
function getToken() {
  return localStorage.getItem("jwt_token");
}
function getUser() {
  return JSON.parse(localStorage.getItem("user_info") || "null");
}

function logout() {
  localStorage.removeItem("jwt_token");
  localStorage.removeItem("user_info");
  window.location.href = "/Login";
}

function showAlert(elementId, message, type = "danger") {
  const el = document.getElementById(elementId);
  if (!el) return;
  el.className = `alert alert-${type}`;
  el.textContent = message;
  el.classList.remove("d-none");
  setTimeout(() => el.classList.add("d-none"), 5000);
}

// Update navbar based on auth state
document.addEventListener("DOMContentLoaded", () => {
  const token = getToken();
  const loginLink = document.getElementById("loginLink");
  const logoutLink = document.getElementById("logoutLink");
  if (token && loginLink && logoutLink) {
    loginLink.classList.add("d-none");
    logoutLink.classList.remove("d-none");
  }
});

// ── Auth ──────────────────────────────────────────────────
async function loginUser() {
  const email = document.getElementById("loginEmail").value.trim();
  const password = document.getElementById("loginPassword").value;

  if (!email || !password) {
    showAlert("loginAlert", "Please fill all fields.");
    return;
  }

  try {
    const res = await fetch(`${API_BASE}/auth/login`, {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({ email, password }),
    });

    if (!res.ok) {
      const err = await res.json();
      showAlert("loginAlert", err.message || "Login failed.");
      return;
    }

    const data = await res.json();
    localStorage.setItem("jwt_token", data.token);
    localStorage.setItem(
      "user_info",
      JSON.stringify({ email: data.email, name: data.fullName }),
    );
    window.location.href = "/Events";
  } catch {
    showAlert("loginAlert", "Cannot connect to server.");
  }
}

async function registerUser() {
  const fullName = document.getElementById("regName").value.trim();
  const email = document.getElementById("regEmail").value.trim();
  const password = document.getElementById("regPassword").value;

  if (!fullName || !email || !password) {
    showAlert("registerAlert", "Please fill all fields.");
    return;
  }
  if (password.length < 6) {
    showAlert("registerAlert", "Password must be at least 6 characters.");
    return;
  }

  try {
    const res = await fetch(`${API_BASE}/auth/register`, {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({ fullName, email, password }),
    });

    if (!res.ok) {
      const err = await res.json();
      const msg = Array.isArray(err)
        ? err.map((e) => e.description).join(" ")
        : "Registration failed.";
      showAlert("registerAlert", msg);
      return;
    }

    showAlert(
      "registerAlert",
      "Registration successful! Please login.",
      "success",
    );
  } catch {
    showAlert("registerAlert", "Cannot connect to server.");
  }
}

// ── Events ────────────────────────────────────────────────
async function loadEvents() {
  const container = document.getElementById("eventsContainer");
  if (!container) return;

  try {
    const res = await fetch(`${API_BASE}/events`);
    const events = await res.json();

    if (events.length === 0) {
      container.innerHTML = `<div class="col-12 text-center py-5 text-muted">No events available.</div>`;
      return;
    }

    container.innerHTML = events
      .map(
        (ev) => `
            <div class="col-md-4 mb-4">
                <div class="card h-100 shadow-sm border-0">
                    <div class="card-header bg-primary text-white">
                        <h5 class="card-title mb-0">${ev.title}</h5>
                    </div>
                    <div class="card-body">
                        <p class="card-text text-muted">${ev.description}</p>
                        <ul class="list-unstyled">
                            <li><i class="bi bi-calendar-date text-primary"></i> 
                                ${new Date(ev.date).toLocaleDateString("en-IN", { dateStyle: "long" })}</li>
                            <li><i class="bi bi-geo-alt text-danger"></i> ${ev.location}</li>
                            <li><i class="bi bi-people text-success"></i> 
                                <strong>${ev.availableSeats}</strong> seats available</li>
                        </ul>
                    </div>
                    <div class="card-footer bg-transparent">
                        <button class="btn btn-primary w-100"
                            onclick="openBookingModal(${ev.id}, '${ev.title}', ${ev.availableSeats})"
                            ${ev.availableSeats === 0 ? "disabled" : ""}>
                            <i class="bi bi-ticket-perforated"></i>
                            ${ev.availableSeats === 0 ? "Sold Out" : "Book Now"}
                        </button>
                    </div>
                </div>
            </div>
        `,
      )
      .join("");
  } catch {
    container.innerHTML = `<div class="col-12"><div class="alert alert-danger">Failed to load events.</div></div>`;
  }
}

// ── Booking Modal ─────────────────────────────────────────
function openBookingModal(eventId, title, availableSeats) {
  if (!getToken()) {
    window.location.href = "/Login";
    return;
  }

  document.getElementById("modalEventId").value = eventId;
  document.getElementById("modalEventTitle").textContent = title;
  document.getElementById("modalAvailableSeats").textContent = availableSeats;
  document.getElementById("seatsInput").value = "";
  document.getElementById("seatsInput").max = availableSeats;
  document.getElementById("bookingAlert").classList.add("d-none");

  new bootstrap.Modal(document.getElementById("bookingModal")).show();
}

async function confirmBooking() {
  const eventId = parseInt(document.getElementById("modalEventId").value);
  const seats = parseInt(document.getElementById("seatsInput").value);
  const available = parseInt(
    document.getElementById("modalAvailableSeats").textContent,
  );

  // Client-side validation
  const seatsInput = document.getElementById("seatsInput");
  seatsInput.classList.remove("is-invalid");

  if (!seats || seats < 1) {
    seatsInput.classList.add("is-invalid");
    document.getElementById("seatsError").textContent =
      "Please enter at least 1 seat.";
    return;
  }
  if (seats > available) {
    seatsInput.classList.add("is-invalid");
    document.getElementById("seatsError").textContent =
      `Only ${available} seats available.`;
    return;
  }
  if (seats > 100) {
    seatsInput.classList.add("is-invalid");
    document.getElementById("seatsError").textContent =
      "Cannot book more than 100 seats at once.";
    return;
  }

  try {
    const res = await fetch(`${API_BASE}/bookings`, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: `Bearer ${getToken()}`,
      },
      body: JSON.stringify({ eventId, seatsBooked: seats }),
    });

    if (!res.ok) {
      const err = await res.json();
      showAlert("bookingAlert", err.message || "Booking failed.");
      return;
    }

    bootstrap.Modal.getInstance(document.getElementById("bookingModal")).hide();
    alert(`✅ Successfully booked ${seats} seat(s)! Check My Bookings.`);
    loadEvents(); // Refresh seat counts
  } catch {
    showAlert("bookingAlert", "Cannot connect to server.");
  }
}

// ── My Bookings ───────────────────────────────────────────
async function loadMyBookings() {
  const tbody = document.getElementById("bookingsBody");
  if (!tbody) return;

  if (!getToken()) {
    window.location.href = "/Login";
    return;
  }

  try {
    const res = await fetch(`${API_BASE}/bookings`, {
      headers: { Authorization: `Bearer ${getToken()}` },
    });

    if (res.status === 401) {
      window.location.href = "/Login";
      return;
    }

    const bookings = await res.json();

    if (bookings.length === 0) {
      tbody.innerHTML = `
                <tr>
                    <td colspan="5" class="text-center py-4 text-muted">
                        No bookings yet. <a href="/Events">Browse events</a>
                    </td>
                </tr>`;
      return;
    }

    tbody.innerHTML = bookings
      .map(
        (b, i) => `
            <tr>
                <td>${i + 1}</td>
                <td><strong>${b.eventTitle}</strong></td>
                <td><span class="badge bg-primary">${b.seatsBooked} seat(s)</span></td>
                <td>${new Date(b.bookedAt).toLocaleDateString("en-IN")}</td>
                <td>
                    <button class="btn btn-sm btn-danger" onclick="cancelBooking(${b.id})">
                        <i class="bi bi-x-circle"></i> Cancel
                    </button>
                </td>
            </tr>
        `,
      )
      .join("");
  } catch {
    showAlert("bookingsAlert", "Failed to load bookings.");
  }
}

async function cancelBooking(bookingId) {
  if (!confirm("Are you sure you want to cancel this booking?")) return;

  try {
    const res = await fetch(`${API_BASE}/bookings/${bookingId}`, {
      method: "DELETE",
      headers: { Authorization: `Bearer ${getToken()}` },
    });

    if (!res.ok) {
      showAlert("bookingsAlert", "Failed to cancel booking.");
      return;
    }

    showAlert("bookingsAlert", "Booking cancelled successfully.", "success");
    loadMyBookings();
  } catch {
    showAlert("bookingsAlert", "Cannot connect to server.");
  }
}

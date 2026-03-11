using System;
using System.Collections.Generic;

namespace LibraryManagement.Models;

public partial class BookBorrower
{
    public int BookId { get; set; }

    public int BorrowerId { get; set; }

    public DateTime? BorrowDate { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual Borrower Borrower { get; set; } = null!;
}

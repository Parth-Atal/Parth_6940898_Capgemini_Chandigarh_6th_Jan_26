using System;
using System.Collections.Generic;

namespace LibraryManagement.Models;

public partial class Borrower
{
    public int BorrowerId { get; set; }

    public string? FullName { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<BookBorrower> BookBorrowers { get; set; } = new List<BookBorrower>();
}

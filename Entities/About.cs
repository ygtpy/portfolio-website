using System;
using System.Collections.Generic;

namespace AkademiQPortfolio.Entities;

public partial class About
{
    public int AboutId { get; set; }

    public string? NameSurname { get; set; }

    public string? Title1 { get; set; }

    public string? Title2 { get; set; }

    public string? Title3 { get; set; }

    public string? Title4 { get; set; }

    public string? Title5 { get; set; }

    public string? Description { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? ImageUrl { get; set; }
}

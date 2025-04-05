using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VoltMartTestWork.Core.Models;

public partial class Employee : BaseModel<int>
{
    [Required(ErrorMessage = "Имя обязательно для заполнения")]
    [StringLength(255, MinimumLength = 2, ErrorMessage = "Длина имени должна быть от 2 до 255 символов")]
    public string Firstname { get; set; }
    [Required(ErrorMessage = "Фамилия обязательно для заполнения")]
    [StringLength(255, MinimumLength = 2, ErrorMessage = "Длина фамилии должна быть от 2 до 255 символов")]
    public string? Lastname { get; set; }
    [StringLength(255, MinimumLength = 2, ErrorMessage = "Длина отчества должна быть от 2 до 255 символов")]
    public string? Midlename { get; set; }
    [RegularExpression(@"^\+?[78][-(]?\d{3}\)?-?\d{3}-?\d{2}-?\d{2}$", ErrorMessage = "Некорректный формат телефонного номера")]
    public string? Phone { get; set; }
    [EmailAddress(ErrorMessage = "Некорректный адрес электронной почты")]
    public string? Email { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Range(typeof(DateOnly), "1900-01-01", "2023-12-31", ErrorMessage = "Дата рождения должна быть между 01.01.1900 и 31.12.2023")]
    public DateOnly? Birthday { get; set; }

    public bool? Isworking { get; set; }

    public bool? Ismarried { get; set; }

    public string? Nowplaceliving { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
    public DateOnly? Hiredate { get; set; }
}

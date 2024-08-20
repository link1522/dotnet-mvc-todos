using System.ComponentModel.DataAnnotations;

namespace dotnet_mvc_todos.Models.ViewModel;

class TodoIndexViewModel
{
    public List<Todo>? Todos { get; set; }

    [Required(ErrorMessage = "{0}欄位必填")]
    [StringLength(50, ErrorMessage = "{0}不能超過{1}個字")]
    [Display(Name = "Title")]
    public string? NewTitle { get; set; }
}
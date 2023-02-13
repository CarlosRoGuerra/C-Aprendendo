using System;
namespace Todo.Models;

public class TodoItem
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}

namespace FubuTodo.Web.Endpoints.Todo.ViewModels
{
  public class Update
  {
    public Update() { }

    public Update(Domain.Todo todo)
    {
      Id = todo.Id;
      Name = todo.Name;
      IsComplete = todo.IsComplete;
    }

    public string Id { get; set; }

    public string Name { get; set; }

    public bool IsComplete { get; set; }
  }
}
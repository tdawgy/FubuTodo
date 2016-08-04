namespace FubuTodo.Domain
{
  public class Todo
  {
    public Todo() { }

    public Todo(string name)
    {
      Name = name;
    }

    public string Id { get; set; }

    public string Name { get; set; }

    public bool IsComplete { get; set; }
  }
}

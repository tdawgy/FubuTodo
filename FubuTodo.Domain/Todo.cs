namespace FubuTodo.Domain
{
  public class Todo
  {
    public Todo() { }

    public Todo(string name, bool isComplete)
    {
      Name = name;
      IsComplete = isComplete;
    }

    public string Id { get; set; }

    public string Name { get; set; }

    public bool IsComplete { get; set; }
  }
}

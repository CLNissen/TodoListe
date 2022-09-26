interface TodoModel{
    id: string;
    name: string;
}
    
type ToggleTodo = (selectedTodo: Todo) => void;
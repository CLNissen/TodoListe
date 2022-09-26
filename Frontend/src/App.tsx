import React, { useState } from 'react';
import { v4 as uuidv4 } from 'uuid'
import { Todo } from './Todo'
import './App.css';

function App() {

  const[todos, setTodos] = useState<any[]>([])
  const[todoInput, setTodoInput] = useState('')

  function handleAddTodo() {
    const name: string = todoInput
    if (name === '') return
    setTodos(prevTodos => {
      return [...prevTodos, {id: uuidv4(), name: name}]
    })
    setTodoInput('')
  }

  const completeTask = (todoIDToDelete: string): void => {
    setTodos(todos.filter((todo) => {
      if (todo.id !== todoIDToDelete) return todo
    }))
  }

  function showInput(e: React.ChangeEvent<HTMLInputElement>) {
    setTodoInput(e.target.value)
    console.log(e.target.value)

  }

  return (
    <div>
    <h1 className="App-header">Very smuk todoliste</h1>
    <Todo todos={todos} completeTask={completeTask} />

    <input 
      className="InputText"
      value={todoInput} 
      onChange={(e) => showInput(e)} 
      type="text"  
    />
    <button className="Button" onClick={handleAddTodo}>Add Todo</button>
    </div>
    )
  
}

export default App;

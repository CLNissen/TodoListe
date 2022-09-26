import React from 'react'

interface Props {
    todos: TodoModel[];
    completeTask(todoIDToDelete: string): void;
}

export const Todo: React.FC<Props> = ({ todos,  completeTask }) => {

    return (

        <div>
            {todos.map((todo) => 
                <div className="todo"> 
                    <div>{todo.name}</div>
                    <button className = "button" onClick={() => {
                        completeTask(todo.id)
                    }}>Finished</button>
                    
                </div>)}
        </div>

    )

}
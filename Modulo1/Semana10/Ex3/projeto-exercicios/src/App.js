import React, { useReducer, useState } from 'react';
import './App.css';

function App() {
  const styleTopItems = { display: 'inline', marginLeft: '10px' }
  const styleDateList = { maxWidth: '15%', margin: '30px auto' }

  const addDate = (state) => {
    var newDate = new Date();
    var mount = `${newDate.getDate()}/${newDate.getMonth() + 1}/${newDate.getFullYear()} ${newDate.getHours()}:${newDate.getMinutes()}:${newDate.getSeconds()}`
    setLastDateId(lastDateId + 1);
    return [...state, { id: lastDateId, content: mount }];
  }

  const removeDate = (state) => {
    setLastDateId(lastDateId - 1);
    return state.slice(0, -1);
  }

  const initialValue = [];
  const [lastDateId, setLastDateId] = useState(1);

  const reducer = (state, action) => {
    switch (action.type) {
      case 'ADICIONAR':
        return addDate(state);
      case 'REMOVER':
        return removeDate(state);
      default:
        return state;
    }
  }
  const [state, dispatch] = useReducer(reducer, initialValue)

  return (
    <div className="App">
      <h1 style={styleTopItems}>Lista de datas</h1>
      <button style={styleTopItems} onClick={() => dispatch({ type: 'ADICIONAR' })}>Adicionar</button>
      <button style={styleTopItems} onClick={() => dispatch({ type: 'REMOVER' })}>Remover</button>
      <ul style={styleDateList}>
        {state.map(e => (
          <li key={e.id}>{e.content}</li>
        )
        )}
      </ul>
    </div>
  );
}

export default App;
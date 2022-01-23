import React, { useReducer, useState } from 'react';
import './App.css';

function App() {
  const TYPES = {
    SOMAR: 'SOMAR',
    SUBTRAIR: 'SUBTRAIR',
    MULTIPLICAR: 'MULTIPLICAR',
    DIVIDIR: 'DIVIDIR'
  };
  
  const reducer = (state, { type, payload}) => {
    switch(type) {
      case TYPES.SOMAR:
        return { result: parseInt(state.result) + parseInt(payload.number)};
      case TYPES.SUBTRAIR:
        return { result: parseInt(state.result) - parseInt(payload.number)};
      case TYPES.MULTIPLICAR:
        return { result: parseInt(state.result) * parseInt(payload.number)};
      case TYPES.DIVIDIR:
        return { result: parseInt(state.result) / parseInt(payload.number)};
      default:
        return state;
    }
  }

  const [state, dispatch] = useReducer(reducer, { result: 0 })
  const [number, setNumber] = useState();
  const [operacao, setOperacao] = useState(TYPES.SOMAR);


  return (
    <>
      <input type="number" value={number} onChange={(e) => setNumber(e.target.value)}></input>
      <select onChange={(e) => setOperacao(e.target.value)} value={operacao}>
        <option value={TYPES.SOMAR}>Somar</option>
        <option value={TYPES.SUBTRAIR}>Subtrair</option>
        <option value={TYPES.MULTIPLICAR}>Multiplicar</option>
        <option value={TYPES.DIVIDIR}>Dividir</option>
      </select>
      <button type="button" onClick={() => dispatch({ type: operacao, payload: { number } })}>Confirmar</button>
      <p>Resultado: {state.result}</p>
    </>
  );
}

export default App;

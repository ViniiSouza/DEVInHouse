import { useState } from 'react';
import { ThemeProvider } from 'styled-components';
import { ModalProvider } from 'styled-react-modal';
import './App.css';
import { AppForm } from './components/AppForm/AppForm';
import { Card } from './components/card';
import { NavBar } from './components/NavBar/NavBar';
import { DarkTheme, GlobalTheme, LightTheme } from './themes/themes';

function App() {
  const dataList = [{ id: 0, nome: 'Nome do Fulano', descricao: 'Descrição do funalo', seguindo: false }]
  const [dados, setDados] = useState(dataList);
  const [isThemeDark, setIsThemeDark] = useState(false);
  const [isRegisterOpen, setIsRegisterOpen] = useState(false);


  function FollowOrNo(id, seguindo) {
    let user = dados.find(where => where.id === id);
    let otherUsers = dados.filter(where => where.id !== id);
    user.seguindo = !seguindo;
    if (otherUsers != null && otherUsers.length > 0) {
      setDados([...otherUsers, user])
    } else {
      setDados([user])
    }
    console.log(dados)
  }

  return (
    <div className="App">
      <ThemeProvider theme={isThemeDark ? DarkTheme : LightTheme}>
        <GlobalTheme />
        <ModalProvider>
          <NavBar isThemeDark={isThemeDark} setIsThemeDark={setIsThemeDark} />
          <button style={{ display: 'block', margin: '10px auto' }} onClick={() => setIsRegisterOpen(true)}>Cadastro</button>
          {dados.map((user) => (
            <Card key={user.id} username={user.nome} description={user.descricao} isFollowing={user.seguindo} setFollow={() => FollowOrNo(user.id, user.seguindo)}></Card>
          ))}
          <AppForm saveUser={{ dados, setDados, isRegisterOpen, setIsRegisterOpen }} ></AppForm>
        </ModalProvider>
      </ThemeProvider>
    </div>
  );
}

export default App;

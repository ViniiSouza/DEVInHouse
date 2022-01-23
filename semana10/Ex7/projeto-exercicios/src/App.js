import './App.css';
import { useLoggedUsers } from './contexts/useLoggedUsers';
import { LoggedUsersProvider } from './contexts/LoggedUsersProvider';

function App() {
  return (
    <div className="App">
      <LoggedUsersProvider>
        <Home></Home>
        <LoginButton></LoginButton>
      </LoggedUsersProvider>
    </div>
  );
}

export const Home = () => {
  const { user } = useLoggedUsers();
  return (
    <>
      {user.autenticado && (
        <h1>{`Bem-vindo ${user.nome}!`}</h1>
      )}
      {!user.autenticado && (
        <h1>Faça o login!</h1>
      )}
    </>
  )
}

export const LoginButton = () => {
  const { user, setUser } = useLoggedUsers();
  return <button onClick={() => setUser({ ...user, autenticado: !user.autenticado })}>{user.autenticado ? 'Logout' : 'Login'}</button>
}

export default App;

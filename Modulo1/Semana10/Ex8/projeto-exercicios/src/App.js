import { useLoggedUsers } from './contexts/LoggedUsers/useLoggedUsers';
import { LoggedUsersProvider } from './contexts/LoggedUsers/LoggedUsersProvider';
import { useAppTheme } from './contexts/AppTheme/useAppTheme';
import { AppThemeProvider } from './contexts/AppTheme/AppThemeProvider';
import { Layout } from './components/layout/Layout';

function App() {

  return (
    <div className="App">
      <AppThemeProvider>
        <Layout>
          <div>
            <h1>Aplicação spaceX</h1>
            <ThemeButton></ThemeButton>
          </div>
          <LoggedUsersProvider>
            <Home></Home>
            <LoginButton></LoginButton>
          </LoggedUsersProvider>
        </Layout >

      </AppThemeProvider>
    </div>
  );
}

export const Home = () => {
  const { user } = useLoggedUsers();
  return (
    <>
      {user.autenticado && (
        <h3>{`Bem-vindo ${user.nome}!`}</h3>
      )}
      {!user.autenticado && (
        <h3>Faça o login!</h3>
      )}
    </>
  )
}

export const LoginButton = () => {
  const { user, setUser } = useLoggedUsers();
  return <button onClick={() => setUser({ ...user, autenticado: !user.autenticado })}>{user.autenticado ? 'Logout' : 'Login'}</button>
}

export const ThemeButton = () => {
  const { theme, setTheme, themeColors } = useAppTheme();
  console.log(themeColors)
  return <button onClick={() => setTheme(theme == 'light' ? 'dark' : 'light')}>{theme == 'light' ? 'Agora é light' : 'Agora é dark'}</button>
}

export default App;

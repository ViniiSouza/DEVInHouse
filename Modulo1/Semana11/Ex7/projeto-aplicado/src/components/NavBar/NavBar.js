import { ChangeTheme, Nav, Title } from "./navbar.styles"

export const NavBar = ({isThemeDark, setIsThemeDark}) => {
    return (
        <Nav isThemeDark={isThemeDark} >
          <Title>Título Aplicação</Title>
          <ChangeTheme onClick={isThemeDark ? () => setIsThemeDark(false) : () => setIsThemeDark(true)}>Alterar tema</ChangeTheme>
        </Nav>
    )
}
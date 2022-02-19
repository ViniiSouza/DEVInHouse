import { Link } from "react-router-dom"

export const Home = () => {

    return (
        <div>
        <p>Bem-vindo</p>
        <footer>
            <Link to="/contatos">Contatos</Link>
        </footer>
    </div>
    )
};
import { Link } from "react-router-dom"

export const Contatos = () => {
    return(
        <div>
            <p>Nome: Fulano</p>
            <p>Telefone: 00 1234-5678</p>
            <br />
            <p><Link to="/">Voltar ao home</Link></p>
        </div>
    )
}
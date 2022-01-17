import PropTypes from 'prop-types'
import './Repository.css'
export const Repository = ({titulo, descricao, destacar}) => {
    return (
        <article>
            <h3 id="repo-title">{titulo}</h3>
            {destacar &&
            <>
                <hr/>
                    <span>*Projeto em destaque*</span>
                <hr/>
            </>
            }
            <p id="repo-description">{descricao}</p>
        </article>
    )
}

Repository.propTypes = {
    titulo: PropTypes.string.isRequired,
    descricao: PropTypes.string,
    destacar: PropTypes.bool
}
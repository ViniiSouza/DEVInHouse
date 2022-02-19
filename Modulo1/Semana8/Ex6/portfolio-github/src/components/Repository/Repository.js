import PropTypes from 'prop-types'
export const Repository = ({titulo, descricao, destacar}) => {
    return (
        <article>
            <h3>{titulo}</h3>
            {destacar &&
                <span>Projeto em destaque!</span>
            }
            <p>{descricao}</p>
        </article>
    )
}

Repository.propTypes = {
    titulo: PropTypes.string.isRequired,
    descricao: PropTypes.string,
    destacar: PropTypes.bool
}
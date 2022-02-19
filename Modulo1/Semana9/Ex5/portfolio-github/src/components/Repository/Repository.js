import PropTypes from 'prop-types'
import './Repository.css'
export const Repository = ({ titulo, descricao, destacar }) => {
    return (
        <article>
            <>
                <div className={destacar ? 'repo-featured-item' : 'repo-item'}>
                    <h5 className="repo-item-title">{titulo}</h5>
                    <p className="repo-item-description">{descricao}</p>
                </div>
            </>
        </article>
    )
}

Repository.propTypes = {
    titulo: PropTypes.string.isRequired,
    descricao: PropTypes.string,
    destacar: PropTypes.bool
}
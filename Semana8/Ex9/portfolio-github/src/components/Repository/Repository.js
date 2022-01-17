import PropTypes from 'prop-types'
import './Repository.css'
export const Repository = ({ titulo, descricao, destacar }) => {
    return (
        <article>
            <h3 id="repo-title">{titulo}</h3>
            {destacar &&
                <>
                    <div className="repo-featured-item">
                        <h5 className="repo-item-title">Projeto destaque</h5>
                        <p className="repo-item-description">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi nunc leo, placerat sed vulputate non, mollis dapibus enim. Phasellus in tincidunt mauris. Donec id ipsum blandit, lobortis est vitae, malesuada ex. Mauris sollicitudin mi felis, a elementum dui molestie sit amet. Curabitur vitae velit malesuada, rhoncus ipsum ac, blandit erat.</p>
                    </div>
                </>
            }
        </article>
    )
}

Repository.propTypes = {
    titulo: PropTypes.string.isRequired,
    descricao: PropTypes.string,
    destacar: PropTypes.bool
}
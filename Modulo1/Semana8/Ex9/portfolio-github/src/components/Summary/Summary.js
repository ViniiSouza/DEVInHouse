import PropTypes from "prop-types";
import './Summary.css'

export const Summary = ({ imgSrc, altText }) => {
    return (
        <div>
            <img id="profile-image" src={imgSrc} alt={altText}></img>
            <p id="alt-text">{altText}</p>
        </div>
    )
}

Summary.propTypes = {
    imgSrc: PropTypes.string.isRequired,
    altText: PropTypes.string.isRequired
}
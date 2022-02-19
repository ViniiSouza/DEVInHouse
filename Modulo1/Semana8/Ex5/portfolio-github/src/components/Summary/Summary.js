import PropTypes from "prop-types";
export const Summary = ({ imgSrc, altText }) => {
    return (
        <div>
            <img src={imgSrc} alt={altText}></img>
            <h2>{altText}</h2>
        </div>
    )
}

Summary.propTypes = {
    imgSrc: PropTypes.string.isRequired,
    altText: PropTypes.string.isRequired
}
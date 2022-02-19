import { CardContainer, CardDescription, FollowButton, Initials, UserName } from "."

export const Card = ({ username, description, isFollowing, setFollow }) => {

    function getInitials() {
        var names = username.split(' '), nameInitials = names[0].substring(0, 1).toUpperCase();
        if (names.length > 1) nameInitials += names[names.length - 1].substring(0, 1).toUpperCase();
        return nameInitials;
    };

    return (
        <CardContainer>
            <Initials>{getInitials()}</Initials>
            <UserName>{username}</UserName>
            <CardDescription>{description}</CardDescription>
            <FollowButton onClick={setFollow} isFollowing={isFollowing}>{isFollowing ? 'Desseguir' : 'Seguir'}</FollowButton>
        </CardContainer>

    )
}
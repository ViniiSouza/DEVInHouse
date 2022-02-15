import styled from 'styled-components';

export const CardContainer = styled.article`
    border: 1px solid red;
    border-radius: 10px;
    max-width: 200px;
    text-align: center;
    font-family: Calibri;
    display: inline-block;
    margin: 10px 15px;
    color: ${(props) => props.theme.colors.primary};
    background-color: ${(props) => props.theme.colors.background};
`;

export const Initials = styled.h3`
    font-size: 32px;
    border: 0.5px solid ${(props) => props.theme.colors.background};
    border-radius: 100px;
    height: 60px;
    width: 60px;
    margin: 20px auto 10px auto;
    background-color: white;
    color: ${(props) => props.theme.colors.primary};
    line-height: 60px;
`;

export const UserName = styled.h6`
    margin: 0;
    font-size: 16px;
    color: ${(props) => props.theme.colors.primary};
`;

export const CardDescription = styled.p`
    text-align: justify;
    font-size: 14px;
    margin: 10px;
    height: 55px;
    width: 170px;
    overflow: hidden;
    color: ${(props) => props.theme.colors.secondary};
`;

export const FollowButton = styled.button`
    background-color: ${props => props.isFollowing ? '#c1e0ff' : '#007fff'};
    font-weight: bold;
    color: ${props => props.isFollowing ? 'black' : 'white'};
    margin: 10px;
    border-radius: 5px;
`;
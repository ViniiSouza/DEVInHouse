import styled from 'styled-components'

export const Nav = styled.nav`
    font-family: Calibri;    
    border: 2px solid ${(props) => props.theme.colors.secondary};
    border-radius: 10px;
    background-color: ${(props) => props.theme.colors.background};
    color: ${(props) => props.theme.colors.primary};
`;

export const Title = styled.h1`
    font-size: 32px;
`;

export const ChangeTheme = styled.button`
    font-family: Calibri;
    font-size: 15px;
    background-color: white;
    font-weight: bold;
    margin-bottom: 10px;
    border-radius: 5px;
`;
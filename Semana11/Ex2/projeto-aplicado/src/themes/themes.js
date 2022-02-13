import { createGlobalStyle } from "styled-components"

export const LightTheme = {
    colors: {
        background: '#00b6ff',
        primary: 'white',
        secondary: 'black'
    }
}

export const DarkTheme = {
    colors: {
        background: '#070363',
        primary: 'white',
        secondary: 'black'
    }
}

export const GlobalTheme = createGlobalStyle`
    margin: 0;
    box-sizing: border-box;
`;
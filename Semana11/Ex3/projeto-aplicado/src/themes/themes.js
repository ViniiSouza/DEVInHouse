import { createGlobalStyle } from "styled-components"

export const LightTheme = {
    colors: {
        background: '#00b6ff',
        primary: '#001687',
        secondary: '#9ee0ff'
    }
}

export const DarkTheme = {
    colors: {
        background: '#070363',
        primary: 'white',
        secondary: '#0099ff'
    }
}

export const GlobalTheme = createGlobalStyle`
    margin: 0;
    box-sizing: border-box;
`;
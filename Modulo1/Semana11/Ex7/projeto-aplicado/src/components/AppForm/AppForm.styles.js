import styled from 'styled-components'
import Modal from 'styled-react-modal'

export const FormContainer = styled.div`
    border: 2px solid ${(props) => props.theme.colors.background};
`;

export const FormName = styled.input`
    border-radius: 5px;
    margin: 10px auto;
    display: block;
`;

export const FormDescription = styled.input`
    border-radius: 5px;
    margin: 10px auto;
    display: block;
`;

export const FormButton = styled.button`
    background-color: ${(props) => props.theme.colors.background};
    color: ${(props) => props.theme.colors.primary};
    border-radius: 5px;
`;

export const StyledModal = Modal.styled`
  border-radius: 15px;
  width: 15rem;
  height: 15rem;
  display: flex;
  align-items: center;
  justify-content: center;
  background-color: ${props => props.theme.colors.background};
`
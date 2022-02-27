import { FormContainer, FormButton, StyledModal } from "./AppForm.styles"
import { Field, Form, Formik } from 'formik';

export const AppForm = ({ saveUser }) => {
    var userList = saveUser.dados

    function addUser(values, actions) {
        var newUser = { id: Math.random(), nome: values.formName, descricao: values.formDescription, seguindo: false }
        var list = [...userList, newUser]
        saveUser.setDados(list)
    }

    return (
        <StyledModal isOpen={saveUser.isRegisterOpen} onBackgroundClick={() => saveUser.setIsRegisterOpen(false)} onEscapeKeydown={() => saveUser.setIsRegisterOpen(false)}>
            <Formik initialValues={{ formName: '', formDescription: '' }} onSubmit={(values, actions) => addUser(values, actions)}>
                <Form>
                    <FormContainer>
                        <Field name="formName"></Field>
                        <hr />
                        <Field name="formDescription"></Field>
                        <hr />
                        <FormButton type="submit">Salvar</FormButton>
                        <hr />
                    </FormContainer>
                    <button onClick={() => saveUser.setIsRegisterOpen(false)}>Cancelar</button>
                </Form>
            </Formik>
        </StyledModal >
    )
}
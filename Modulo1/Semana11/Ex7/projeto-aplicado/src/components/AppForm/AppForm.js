import { FormContainer, FormButton, StyledModal } from "./AppForm.styles"
import { ErrorMessage, Field, Form, Formik } from 'formik';
import * as Yup from 'yup';

export const AppForm = ({ saveUser }) => {
    var userList = saveUser.dados

    function addUser(values, actions) {
        var newUser = { id: Math.random(), nome: values.formName, descricao: values.formDescription, seguindo: false }
        var list = [...userList, newUser]
        saveUser.setDados(list)
    }

    const schema = Yup.object().shape({
        formName: Yup.string().required('Campo obrigatório').max(100, 'Máximo de 100 caracteres'),
        formDescription: Yup.string().required('Campo obrigatório').min(10, 'Mínimo de 10 caracteres')
    })

    return (
        <StyledModal validationSchema={schema} isOpen={saveUser.isRegisterOpen} onBackgroundClick={() => saveUser.setIsRegisterOpen(false)} onEscapeKeydown={() => saveUser.setIsRegisterOpen(false)}>
            <Formik initialValues={{ formName: '', formDescription: '' }} onSubmit={(values, actions) => addUser(values, actions)}>
                {({ isSubmitting, isValid }) => (

                    <Form>
                    <FormContainer>
                        <Field name="formName"></Field>
                        <ErrorMessage name="formName"></ErrorMessage>
                        <hr />
                        <Field name="formDescription"></Field>
                        <ErrorMessage name="formDescription"></ErrorMessage>
                        <hr />
                        <FormButton disabled={isSubmitting || !isValid} type="submit">Salvar</FormButton>
                        <hr />
                    </FormContainer>
                    <button onClick={() => saveUser.setIsRegisterOpen(false)}>Cancelar</button>
                </Form>
                )}
            </Formik>
        </StyledModal >
    )
}
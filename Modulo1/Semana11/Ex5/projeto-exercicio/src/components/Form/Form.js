import { ErrorMessage, Field, Form, Formik } from 'formik';
import * as Yup from 'yup';

export const Formulario = () => {
    var initialValues = {
        nome: '',
        nascimento: '',
        email: '',
        telefone: '',
        endereco: {
            rua: '',
            numero: '',
            complemento: '',
            bairro: '',
            cidade: '',
            estado: ''
        }
    }

    const schema = Yup.object().shape({
        nome: Yup.string().required('Campo obrigatório'),
        email: Yup.string().required('Campo obrigatório').email('E-mail inválido'),
        endereco: Yup.object().shape({
            rua: Yup.string().required('Campo obrigatório'),
            numero: Yup.string().required('Campo obrigatório'),
            bairro: Yup.string().required('Campo obrigatório'),
            cidade: Yup.string().required('Campo obrigatório'),
            estado: Yup.string().required('Campo obrigatório')
    })
    
    })

    const handleSubmit = (values, { setSubmitting, resetForm }) => {
        console.log(values)
    }

    return (
        <Formik initialValues={initialValues} onSubmit={handleSubmit} validationSchema={schema} >
            {({ resetForm, isSubmitting, isValid }) => (
            <Form style={{width: '9%'}}>
                <label>Nome</label>
                <Field name="nome"></Field>
                <ErrorMessage style={ { marginTop: '0', color: 'red', fontSize: '13px'} } name="nome" component="p" />
                <label>Date de nascimento</label>
                <Field name="nascimento"></Field>
                <label>E-mail</label>
                <Field name="email"></Field>
                <ErrorMessage style={ { marginTop: '0', color: 'red', fontSize: '13px'} } name="email" component="p" />
                <label>Telefone</label>
                <Field name="telefone"></Field>
                <label>Endereço</label>
                <br />
                <label>Rua</label>
                <Field name="endereco.rua" placeholder="Rua"></Field>
                <ErrorMessage style={ { marginTop: '0', color: 'red', fontSize: '13px'} } name="endereco.rua" component="p" />
                <label>Número</label>
                <Field name="endereco.numero" placeholder="Número"></Field>
                <ErrorMessage style={ { marginTop: '0', color: 'red', fontSize: '13px'} } name="endereco.numero" component="p" />
                <label>Complemento</label>
                <Field name="endereco.complemento" placeholder="Complemento"></Field>
                <label>Bairro</label>
                <Field name="endereco.bairro" placeholder="Bairro"></Field>
                <ErrorMessage style={ { marginTop: '0', color: 'red', fontSize: '13px'} } name="endereco.bairro" component="p" />
                <label>Cidade</label>
                <Field name="endereco.cidade" placeholder="Cidade"></Field>
                <ErrorMessage style={ { marginTop: '0', color: 'red', fontSize: '13px'} } name="endereco.cidade" component="p" />
                <label>Estado</label>
                <Field name="endereco.estado" placeholder="Estado"></Field>
                <ErrorMessage style={ { marginTop: '0', color: 'red', fontSize: '13px'} } name="endereco.estado" component="p" />
                <button type="submit" disabled={isSubmitting || !isValid}>Enviar</button>
                <button type="button" onClick={resetForm}>Limpar</button>
            </Form>
            )}
        </Formik>
    )
}
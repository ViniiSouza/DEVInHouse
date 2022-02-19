import { Field, Form, Formik } from 'formik';

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
    const handleSubmit = (values, { setSubmitting, resetForm }) => {
        console.log(values)
        resetForm(initialValues);
    }

    return (
        <Formik initialValues={initialValues} onSubmit={handleSubmit}>
            {({ resetForm }) => (
            <Form style={{width: '9%'}}>
                <label>Nome</label>
                <Field name="nome"></Field>
                <label>Date de nascimento</label>
                <Field name="nascimento"></Field>
                <label>E-mail</label>
                <Field name="email"></Field>
                <label>Telefone</label>
                <Field name="telefone"></Field>
                <label>Endereço</label>
                <br />
                <label>Rua</label>
                <Field name="endereco.rua" placeholder="Rua"></Field>
                <label>Número</label>
                <Field name="endereco.numero" placeholder="Número"></Field>
                <label>Complemento</label>
                <Field name="endereco.complemento" placeholder="Complemento"></Field>
                <label>Bairro</label>
                <Field name="endereco.bairro" placeholder="Bairro"></Field>
                <label>Cidade</label>
                <Field name="endereco.cidade" placeholder="Cidade"></Field>
                <label>Estado</label>
                <Field name="endereco.estado" placeholder="Estado"></Field>
                <button type="submit">Enviar</button>
                <button type="button" onClick={resetForm}>Limpar</button>
            </Form>
            )}
        </Formik>
    )
}
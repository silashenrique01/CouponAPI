const mongoose= requise('mongoose');
const Schema = mongoose.Schema;

const usuarioSchema = new Schema ({
    name: String,
    cpf: Number,
    email: vachar,
    senha: varchar

})
const cupomSchema = new Schema ({
    nameLoja: String,
    tipoCupom: String,
    dataCupom: Number,
    dataVencCupom: Number,
    valorCupom: Number

})
const relatorioSchema = new Schema ({
    dadosCupom: String,
    tipoRelarorio: vachar
    
})

mongoose.model('usuario', usuarioSchema);
mongoose.model('cupom', cupomSchema);
mongoose.model('relatorio', relatorioSchema);
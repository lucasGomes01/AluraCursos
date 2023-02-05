import React from "react";
import { ITarefa } from "../../types/tarefa";
import Botao from "../Botao";
import style from './Formulario.module.scss'
import { v4 as uuidv4 } from 'uuid';
class Formulario extends React.Component<{
    setTarefas: React.Dispatch<React.SetStateAction<ITarefa[]>>
}> {
    state = {
        tarefa: "",
        tempo: "00:00"
    }

    adicionarTarefa(evento: React.FormEvent) {
        evento.preventDefault();
        this.props.setTarefas(tarefasAntigas => [...tarefasAntigas, { ...this.state, selecionado: false, completado: false, id: uuidv4() }]);
        this.setState({
            tarefa: "",
            tempo: "00:00"
        })
    }

    render () {
        return (
            <form className={style.novaTarefa} onSubmit={this.adicionarTarefa.bind(this)}>
                <div className={style.inputContainer}>
                    <label htmlFor="tarefa">
                        Adicione um novo estudo
                    </label>
                    <input id="tarefa" value={this.state.tarefa} onChange={evento => this.setState({ ...this.state, tarefa: evento.target.value})} name="tarefa" placeholder="O que você quer estudar" type="text" required />
                </div>
                <div className={style.inputContainer}>
                    <label htmlFor="tempo">
                        Tempo
                    </label>
                    <input id="tempo" value= {this.state.tempo} onChange={evento => this.setState({...this.state, tempo: evento.target.value })} max="01:30:00" min="00:00:00" name="tempo" step="1" type="time" required />
                </div>
                <Botao type="submit"> Adicionar </Botao>
            </form>
        )
    }
}

export default Formulario;
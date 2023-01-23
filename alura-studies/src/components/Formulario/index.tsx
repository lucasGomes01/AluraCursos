import React from "react";
import Botao from "../Botao";

class Formulario extends React.Component {
    render () {
        return (
            <form>
                <div>
                    <label htmlFor="tarefa">
                        Adicione um novo estudo
                    </label>
                    <input id="tarefa" name="tarefa" placeholder="O que você quer estudar" type="text" required />
                </div>
                <div>
                    <label htmlFor="tempo">
                        Tempo
                    </label>
                    <input id="tempo" max="01:30:00" min="00:00:00" name="tempo" step="1" type="time" required />
                </div>
                <Botao/>
            </form>
        )
    }
}

export default Formulario;
import {useEffect,useState} from 'react'
import {Categoria} from '../Models/Categoria'
import {Tarefa} from '../Models/Tarefa'

function TarefaListar(){
    const [tarefas, setTarefas] = useState<Tarefa[]>([]);

    useEffect(() => {
        fetch("http://localhost:5000/api/tarefa/listar")
          .then((resposta) => {
            return resposta.json();
          })
          .then((tarefas) => {
            setTarefas(tarefas);
          });
      });

      return (
        <div>
            <table>
                <thead>
                    <tr>
                        <th>Nome</th>
                        <th>Desc</th>
                    </tr>
                </thead>
            </table>
        </div>
      )
}
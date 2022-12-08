/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package tp_final;
import java.util.ArrayList;

/**
 *
 * @author gabri
 */
public class Alunos {
    private ArrayList<Aluno> alunos;
    
    public Alunos(){
        this.alunos = new ArrayList<Aluno>();
    }
    
    public void adicionar(Aluno aluno){
        this.alunos.add(aluno);
    }
    
    public ArrayList<Aluno> getAlunos(){
        return this.alunos;
    }
    
    public void setAlunos(ArrayList<Aluno> alunos){
        this.alunos = alunos;
    }
    
}

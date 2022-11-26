/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package tp_04;
import java.util.ArrayList;
/**
 *
 * @author gabri
 */
public class Funcionarios {
    private final ArrayList<Funcionario> funcionarios = new ArrayList<Funcionario>();
    
    public void adicionar(Funcionario func){
        this.funcionarios.add(func);
    }
    
    public ArrayList<Funcionario> getFuncionarios(){
        return this.funcionarios;
    }
}

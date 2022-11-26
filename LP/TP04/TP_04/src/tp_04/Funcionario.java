/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package tp_04;

/**
 *
 * @author gabri
 */
public class Funcionario {
    private String nome;
    private String salario;
    private String cargo;
    
    public Funcionario(){
        this.nome = null;
    }
    
    public Funcionario(String nome, String salario, String cargo){
        this.nome = nome;
        this.salario = salario;
        this.cargo = cargo;
    }
    
    public void setNome(String nome){
        this.nome = nome;
    }
    
    public void setSalario(String salario){
        this.salario = salario;
    }
    
    public void setCargo(String cargo){
        this.cargo = cargo;
    }
    
    public String getNome(){
        return this.nome;
    }
    
    public String getSalario(){
        return this.salario;
    }
    
    public String getCargo(){
        return this.cargo;
    }
    
}

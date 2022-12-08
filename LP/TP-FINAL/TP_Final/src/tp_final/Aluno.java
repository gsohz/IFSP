/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package tp_final;

/**
 *
 * @author gabri
 */
public class Aluno {
    private String nome;
    private int idade;
    private float peso;
    private float altura;
    private String objetivo;
    
    public Aluno(){
        this.nome = null;
    }
    
    public Aluno(String nome, int idade, float peso, float altura, String objetivo){
        this.nome = nome;
        this.idade = idade;
        this.peso = peso;
        this.altura = altura;
        this.objetivo = objetivo;
    }
    
    public void setNome(String nome){
        this.nome = nome;
    }
    
    public void setIdade(int idade){
        this.idade = idade;
    }
    
    public void setPeso(float peso){
        this.peso = peso;
    }
    
    public void setAltura(float altura){
        this.altura = altura;
    }
    
    public void setObjetivo(String objetivo){
        this.objetivo = objetivo;
    }
    
    public String getNome(){
        return this.nome;
    }
    
    public int getIdade(){
        return this.idade;
    }
    
    public float getPeso(){
        return this.peso;
    }
    
    public float getAltura(){
        return this.altura;
    }
    
    public String getObjetivo(){
        return this.objetivo;
    }
}

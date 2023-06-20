import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-pessoa-cadastro',
  templateUrl: './pessoa-cadastro.component.html',
  styleUrls: ['./pessoa-cadastro.component.css']
})
export class PessoaCadastroComponent implements OnInit {

  public formulario: FormGroup;
  public formSubmetido: boolean = false;

  constructor(
    public formBuilder: FormBuilder,
  ) { }

  public ngOnInit(): void {
    document.title = 'Cadastro de pessoa';
    this.inicializarConfigForm();
  }

  public submeterForm(): void {

  }

  private inicializarConfigForm(): void {
    this.formulario = this.formBuilder.group({
      id: [0],
      nome: [null, [Validators.required, Validators.maxLength(100)]],
      cpf: [null, [Validators.required, Validators.maxLength(14)]],
      email: [null, [Validators.email]],
      telefone: [null, [Validators.maxLength(30)]],
    });
  }

}

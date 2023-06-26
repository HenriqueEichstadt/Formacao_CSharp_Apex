import { AlertService } from './../../services/alert.service';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import Pessoa from 'src/app/models/pessoa.model';
import { PessoaService } from 'src/app/services/pessoa.service';

@Component({
  selector: 'app-pessoa-cadastro',
  templateUrl: './pessoa-cadastro.component.html',
  styleUrls: ['./pessoa-cadastro.component.css']
})
export class PessoaCadastroComponent implements OnInit {

  public formulario: FormGroup;
  public formSubmetido: boolean = false;
  public id: number = null;

  constructor(
    public formBuilder: FormBuilder,
    public router: Router,
    public activatedRoute: ActivatedRoute,
    public pessoaService: PessoaService,
    public alertService: AlertService
  ) { }

  public ngOnInit(): void {
    this.id = this.activatedRoute.snapshot.params['id'];

    if(this.id == null) {
      document.title = 'Cadastro de pessoa';
    } else {
      document.title = 'Edição de pessoa';
      this.chamarApiParaObterPessoaPorId(this.id);
    }

    this.inicializarConfigForm();
  }

  public submeterForm(): void {
    this.formSubmetido = true;

    if(this.formulario.invalid) {
      return;
    }

    let pessoa: Pessoa = new Pessoa(this.formulario.getRawValue());

    if(this.id == null) {
      this.chamarApiParaAdicionar(pessoa);
    } else {
      this.chamarApiParaAtualizar(pessoa);
    }

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

  public chamarApiParaAdicionar(pessoa: Pessoa): void {
    this.pessoaService.adicionar(pessoa).subscribe(resposta => {

      if(resposta != null) {
        this.alertService.showToastrSuccess('Pessoa cadastrada com sucesso');
        this.router.navigate(['/pessoa/listagem']);
      } else {
        this.alertService.showToastrError('Erro ao cadastrar pessoa');
      }

    });
  }

  public chamarApiParaAtualizar(pessoa: Pessoa): void {
    this.pessoaService.atualizar(pessoa).subscribe(resposta => {

      if(resposta != null) {
        this.alertService.showToastrSuccess('Pessoa atualizada com sucesso');
        this.router.navigate(['/pessoa/listagem']);
      } else {
        this.alertService.showToastrError('Erro ao atualizar pessoa');
      }

    });
  }

  public chamarApiParaObterPessoaPorId(id: number): void {
    this.pessoaService.obterPorId(id).subscribe(resposta => {

      if(resposta != null) {
        this.formulario.patchValue(resposta);
      }

    });
  }

}

import { AlertService } from './../../services/alert.service';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import {UsuarioService} from "../../services/usuario.service";
import Usuario from "../../models/usuario.model";
import {AutenticacaoService} from "../../services/autenticacao.service";

@Component({
  selector: 'app-usuario-cadastro',
  templateUrl: './usuario-cadastro.component.html',
  styleUrls: ['./usuario-cadastro.component.css']
})
export class UsuarioCadastroComponent implements OnInit {

  public formulario: FormGroup;
  public formSubmetido: boolean = false;
  public id: number = null;

  constructor(
    public formBuilder: FormBuilder,
    public router: Router,
    public activatedRoute: ActivatedRoute,
    public autenticacaoService: AutenticacaoService,
    public usuarioService: UsuarioService,
    public alertService: AlertService
  ) { }

  public ngOnInit(): void {
    this.id = this.activatedRoute.snapshot.params['id'];

    if(!this.autenticacaoService.tipoPerfilEhAdmin() && (this.id == null || this.id != this.autenticacaoService.obterIdUsuario())) {
      this.router.navigate(['/principal']);
    }

    if(this.id == null) {
      document.title = 'Cadastro de usuário';
    } else {
      document.title = 'Edição de usuário';
      this.chamarApiParaObterUsuarioPorId(this.id);
    }

    this.inicializarConfigForm();
  }

  public submeterForm(): void {
    this.formSubmetido = true;

    if(this.formulario.invalid) {
      return;
    }

    let usuario: Usuario = new Usuario(this.formulario.getRawValue());

    if(this.id == null) {
      this.chamarApiParaAdicionar(usuario);
    } else {
      this.chamarApiParaAtualizar(usuario);
    }

  }

  private inicializarConfigForm(): void {
    this.formulario = this.formBuilder.group({
      id: [0],
      nomeUsuario: [null, [Validators.required, Validators.maxLength(150)]],
      email: [null, [Validators.required, Validators.maxLength(150), Validators.email]],
      senha: [null, [Validators.required, Validators.maxLength(150)]],
      ativo: [null, [Validators.required]],
      tipo: [null, [Validators.required, Validators.maxLength(30)]],
    });
  }

  public chamarApiParaAdicionar(usuario: Usuario): void {
    this.usuarioService.adicionar(usuario).subscribe(resposta => {

      if(resposta != null) {
        this.alertService.showToastrSuccess('Usuário cadastrado com sucesso');
        this.router.navigate(['/usuario/listagem']);
      } else {
        this.alertService.showToastrError('Erro ao cadastrar usuário');
      }

    }, exception => {
      let mensagemErro = exception?.error instanceof String ? exception?.error : '';
      this.alertService.showToastrError('Erro ao conectar com o servidor', mensagemErro);
    });
  }

  public chamarApiParaAtualizar(usuario: Usuario): void {
    this.usuarioService.atualizar(usuario).subscribe(resposta => {

      if(resposta != null) {
        this.alertService.showToastrSuccess('Usuário atualizado com sucesso');
        this.router.navigate(['/usuario/listagem']);
      } else {
        this.alertService.showToastrError('Erro ao atualizar usuário');
      }

    }, exception => {
      let mensagemErro = exception?.error instanceof String ? exception?.error : '';
      this.alertService.showToastrError('Erro ao conectar com o servidor', mensagemErro);
    });
  }

  public chamarApiParaObterUsuarioPorId(id: number): void {
    this.usuarioService.obterPorId(id).subscribe(resposta => {

      if(resposta != null) {
        this.formulario.patchValue(resposta);
      }

    }, exception => {
      let mensagemErro = exception?.error instanceof String ? exception?.error : '';
      this.alertService.showToastrError('Erro ao conectar com o servidor', mensagemErro);
    });
  }

}

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MenuPrincipalComponent } from './pages/menu-principal/menu-principal.component';
import { BarraSuperiorComponent } from './components/barra-superior/barra-superior.component';
import { PessoaListagemComponent } from './pages/pessoa-listagem/pessoa-listagem.component';
import { PessoaCadastroComponent } from './pages/pessoa-cadastro/pessoa-cadastro.component';
import { CommonModule } from '@angular/common';
import {HTTP_INTERCEPTORS, HttpClientJsonpModule, HttpClientModule} from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ValidatorComponent } from './components/validator/validator.component';
import { ToastrModule } from 'ngx-toastr';
import { NgxMaskModule } from 'ngx-mask';
import { CpfPipe } from './pipes/cpf.pipe';
import { TelefonePipe } from './pipes/telefone.pipe';
import {UsuarioLogadoGuard} from "./guards/usuario-logado.guard";
import { LoginComponent } from './pages/login/login.component';
import {AuthInterceptor} from "./interceptors/requisicao.interceptor";
import {UsuarioListagemComponent} from "./pages/usuario-listagem/usuario-listagem.component";
import {UsuarioCadastroComponent} from "./pages/usuario-cadastro/usuario-cadastro.component";

@NgModule({
  declarations: [
    AppComponent,
    MenuPrincipalComponent,
    BarraSuperiorComponent,
    PessoaListagemComponent,
    PessoaCadastroComponent,
    UsuarioListagemComponent,
    UsuarioCadastroComponent,
    ValidatorComponent,
    CpfPipe,
    TelefonePipe,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CommonModule,
    BrowserAnimationsModule,
    HttpClientModule,
    HttpClientJsonpModule,
    FormsModule,
    ReactiveFormsModule,
    ToastrModule.forRoot(),
    NgxMaskModule.forRoot(),
  ],
  providers: [
    UsuarioLogadoGuard,
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterceptor,
      multi: true
    },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import Usuario from "../models/usuario.model";

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  private urlBase = 'http://localhost:5000/';

  constructor(
    public httpClient: HttpClient
  ) { }

  public adicionar(usuario: Usuario) {
    return this.httpClient.post<Usuario>(this.urlBase + 'usuario/adicionar', usuario);
  }

  public atualizar(usuario: Usuario) {
    return this.httpClient.put<Usuario>(this.urlBase + 'usuario/atualizar', usuario);
  }

  public alterarStatus(id: number) {
    return this.httpClient.put<any>(this.urlBase + 'usuario/alterarStatus/' + id, null);
  }

  public obterPorId(id: number) {
    return this.httpClient.get<Usuario>(this.urlBase + 'usuario/obterPorId/' + id);
  }

  public obterTodos() {
    return this.httpClient.get<Usuario[]>(this.urlBase + 'usuario/obterTodos');
  }

}

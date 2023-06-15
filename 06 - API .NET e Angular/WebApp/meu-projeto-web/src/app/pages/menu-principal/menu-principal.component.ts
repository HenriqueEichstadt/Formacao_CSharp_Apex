import { Component, OnDestroy, OnInit } from '@angular/core';

@Component({
  selector: 'app-menu-principal',
  templateUrl: './menu-principal.component.html',
  styleUrls: ['./menu-principal.component.css']
})
export class MenuPrincipalComponent implements OnInit, OnDestroy {

  // propriedades
  public titlee: string = 'Meu projeto WEB';
  teste = 'teste 123';
  public deveRenderizarPalavraRecursos: boolean = false;

  // métodos
  public ngOnInit(): void {
    document.title = 'Menu principal';
  }

  public ngOnDestroy(): void {

  }

  public imprimir(): void {
    alert('Imprimir foi clicado');
  }

  public soma(valor1: number, valor2: number): number {
    return valor1 + valor2;
  }

  public metodoQualquer(parametro: any): any {

  }

}

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MenuPrincipalComponent } from './pages/menu-principal/menu-principal.component';
import { BarraSuperiorComponent } from './components/barra-superior/barra-superior.component';

@NgModule({
  declarations: [
    AppComponent,
    MenuPrincipalComponent,
    BarraSuperiorComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

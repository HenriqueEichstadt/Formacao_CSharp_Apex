import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MenuPrincipalComponent } from './pages/menu-principal/menu-principal.component';
import { BarraSuperiorComponent } from './components/barra-superior/barra-superior.component';

const routes: Routes = [
  { path: '', redirectTo: '/principal', pathMatch: 'full' },
  {
    path: '',
    component: BarraSuperiorComponent,
    children: [
      { path: 'principal', component: MenuPrincipalComponent },
    ]
  },
  { path: '**', redirectTo: '/principal', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

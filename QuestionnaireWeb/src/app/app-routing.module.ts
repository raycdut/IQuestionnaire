import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: '', redirectTo: '/myquestion', pathMatch: 'full'},
  { path: 'home', loadChildren: 'app/home/home.module#HomeModule'},
  { path: 'myquestion', loadChildren: 'app/my-questionnaire/my-questionnaire.module#MyQuestionnaireModule'}
  // { path: '',}
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes
     , { enableTracing: true }
    )
  ],
  declarations: [],
  exports: [ RouterModule ]
})
export class AppRoutingModule { }

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { QuestionnaireLayoutComponent } from './questionnaire-layout/questionnaire-layout.component';
import { QuestionnaireCreateComponent } from './questionnaire-create/questionnaire-create.component';
import { QuestionnaireDashboardComponent } from './questionnaire-dashboard/questionnaire-dashboard.component';

const routes: Routes = [
  {path: '', redirectTo : '/myquestion/manager' , pathMatch: 'full'},
  {path: 'manager', component: QuestionnaireLayoutComponent, children: [
    {path: '', redirectTo: 'dashboard', pathMatch: 'full'},
    {path: 'create', component: QuestionnaireCreateComponent},
    {path: 'dashboard', component: QuestionnaireDashboardComponent}
  ]}

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MyQuestionnaireRoutingModule { }

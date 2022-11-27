import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/models/employee.model';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.css'],
})
export class EmployeesListComponent implements OnInit {
  employees: Employee[] = [
    {
      id: '123',
      name: 'John Doe',
      email: 'john.doe@hello.com',
      phone: 31231232,
      salary: 1000,
      department: 'HR',
    },
    {
      id: '456',
      name: 'Jane Doe',
      email: 'jane.doe@hello.com',
      phone: 12312,
      salary: 101241200,
      department: 'Software',
    },
    {
      id: '456',
      name: 'Sam Smith',
      email: 'sam.mith@hello.com',
      phone: 5235235262,
      salary: 1,
      department: 'Marketing',
    },
  ];
  constructor() {}
  ngOnInit(): void {}
}

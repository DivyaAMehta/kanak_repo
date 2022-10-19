import React from 'react'
import App from '../App'
//need to write all component on same page if not passing as props
const Firstassign = () => {
  const car = {
    model: 'i20',
    company: 'Hyundai',
    price: 20,
    configuration: {
     color: 'gray',
     fuel: 'petrol',
     cylinder: 4,
     fuelTankCapacity: 37,
     mileage: {
     city: 14,
     highway: 20,
     },
     },
    features: ['touch screen', 'bluetooth', 'alloy wheels', 'powersteering'],
    }

  
    return (
<div>
      <ul class="list-group">
        <li class="list-group-item active" aria-current="true" >CAR</li>
        <ul>
          <li class="list-group-item">model: {car.model}</li>
          <li class="list-group-item">company: {car.company}</li>
          <li class="list-group-item">price: {car.price}L</li>
        </ul>
        <li class="list-group-item active" aria-current="true">configuration</li>
        <ul>
          <li class="list-group-item">color: {car.configuration.color}</li>
          <li class="list-group-item">fuel:  {car.configuration.fuel}</li>
          <li class="list-group-item">cylinder: {car.configuration.cylinder}</li>
          <li class="list-group-item">fuelTankCapacity: {car.configuration.fuelTankCapacity}</li>
        </ul>
        <li class="list-group-item active" aria-current="true">MileAge</li>
        <ul>
          <li class="list-group-item">city: {car.configuration.mileage.city}</li>
          <li class="list-group-item">highway:{car.configuration.mileage.highway}</li>

        </ul>

        <li class="list-group-item active" aria-current="true">Features</li>
       <ul>
        
        {car.features.map((vals)=>{
          return (
            <li class="list-group-item">
            {vals}
          </li>
          )
        })}
       </ul>
       

      </ul>
</div>
  )
}

export default Firstassign;
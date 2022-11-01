
import './App.css';
import SignUp from './components/SignUp';
import SignUpUser from './components/SignUpUser';
import AddHotelInfo from './components/AddHotelInfo';
import { BrowserRouter, Routes ,Route } from 'react-router-dom';
import { FirstPage } from './components/FirstPage';
import RegisterNewUser from './components/RegisterNewUser';
import RegisterNew from './components/RegisteNew';
import NavBar from './components/NavBar';
import NavBar2 from './components/NavBar';
import array from './components/AddHotelInfo'
import FirstPageUser from './components/FirstPageUser';
import BookTable from './components/BookTable';

function App() {
  const hotelInfo=[{id:1,hotelName:'Hotel Fun',title:'Come and have fun',img:'https://pix8.agoda.net/hotelImages/124/1246280/1246280_16061017110043391702.jpg?ca=6&ce=1&s=1024x768', rooms:7},
  {id:2,hotelName:'name2',title:'title2',img:'https://pix8.agoda.net/hotelImages/124/1246280/1246280_16061017110043391704.jpg?ca=6&ce=1&s=1024x768',rooms:5}]
 
 const registerUsers=[{id:'user@1',pass:'user@1'},{id:'user@2',pass:'user@2'},{id:'user@3',pass:'user@3'}]
  return (
    <div>
      <BrowserRouter>
      <Routes>
      <Route path='/' element={<SignUp/>}/>
      <Route path='/SignUpUser' element={<SignUpUser/>}/>
      <Route path='/NavBar2' element={<NavBar/>}/>
      <Route path='/AddHotelInfo' element={<AddHotelInfo hotelInfo={hotelInfo}/>}/>
      <Route path='/NavBar' element={<NavBar/>}/>
      <Route path='/RegisterNew' element={<RegisterNew/>}/>
      <Route path='/BookTable' element={<BookTable hotelInfo={hotelInfo}/>}/>
      <Route path='/FirstPage' element={<FirstPage hotelInfo={hotelInfo}/>}/>
      <Route path='/FirstPageUser' element={<FirstPageUser hotelInfo={hotelInfo}/>}/>
      <Route path='/RegisterNewUser' element={<RegisterNewUser registerUsers={registerUsers}/>}/>
     
      </Routes>
      </BrowserRouter>
     
    </div>
  );
}

export default App;


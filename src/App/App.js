import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Navbar from '../components/Navbar/Navbar';
import Home from '../views/Home/Home';

export default function App() {
  
  return (
   <>
    <div className= "App"> 
    <Router>
      <Navbar />
        <Routes>
        <Route exact path="/" element={<Home />}/>
        </Routes>
    </Router>
    </div>
    </>
  )
}

import React, { useEffect, useState } from 'react';
import dayjs, { Dayjs } from 'dayjs';
import { Line } from 'react-chartjs-2';
import {
  Chart as ChartJS,
  CategoryScale,
  LinearScale,
  PointElement,
  LineElement,
  Filler,
  Title,
  Tooltip,
  Legend,
} from 'chart.js';
import agent from './app/api/agent';
import { Box, CssBaseline, Divider, SelectChangeEvent } from '@mui/material';
import Navbar from './app/components/Navbar';
import ModalDialogue from './app/components/ModalDialogue';
import Selectors from './app/components/Selectors';


ChartJS.register(
  CategoryScale,
  LinearScale,
  PointElement,
  LineElement,
  Filler,
  Title,
  Tooltip,
  Legend
);

function App() {
  const [dates, setDates] = useState<any>([]);
  const [type, setType] = React.useState('');
  const [from, setFrom] = React.useState<Dayjs | null>(null);
  const [to, setTo] = React.useState<Dayjs | null>(null);
  const [y, setY] = useState<any>([]);
  const [x, setX] = useState<any>([]);
  const [open, setOpen] = useState(false);
  const [userData, setUserData] = useState({
    labels: x,
    datasets: [
    {   
      fill: true,
      label: 'The Level',
      data: y,
      borderColor: 'rgb(255, 99, 132)',
      backgroundColor: 'pink',
    }]
  });

  const handleClickOpen = () => {
      setOpen(true);
  };

  const handleClose = () => {
      setOpen(false);
  };

  useEffect(() => {
    console.log(typeof(type));
    if (type === '10') {
      agent.Lumber.open().then(a => setY(a));
    } else if (type === '20') {
      agent.Lumber.close().then(a => setY(a));
    } else if (type === '30') {
      agent.Lumber.adjclose().then(a => setY(a));
    } else if (type === '40') {
      agent.Lumber.high().then(a => setY(a));
    } else if (type === '50') {
      agent.Lumber.low().then(a => setY(a));
    } else if (type === '60') {
      agent.Lumber.volume().then(a => setY(a));
    }
    agent.Lumber.date().then(a => {setX(a); setDates(a);});
  }, [type])

  const onClick = () => {
    var arr = x;
    if (from && to){
      arr = dates.filter((date:Date) => dayjs(date).isAfter(from) && dayjs(date).isBefore(to))
      setX(arr);
    }
  }

  useEffect(() => {
    setUserData({
      labels: x.map((date:Date) => dayjs(date).format('DD/MM/YYYY')),
      datasets: [{   
        fill: true,
        label: 'Value',
        data: y,
        borderColor: 'rgb(255, 110, 48)',
        backgroundColor: 'rgba(255, 110, 48, 0.5)'
      }]
    })
  }, [x,y])

  const handleChange = (event: SelectChangeEvent) => {
    setType(event.target.value.toString());
  };

  const options = {
    responsive: true,
    plugins: {
      legend: {
        position: 'top' as const,
      },
    }
  };

  return (
    <>
      <CssBaseline />
      <Navbar />
      <Box sx={{width: '100%', backgroundColor: '#3e3c2f', paddingTop: 2}}>
        <Selectors handleClickOpen={handleClickOpen} handleChange={handleChange} onClick={onClick} type={type} from={from} setFrom={setFrom} to={to} setTo={setTo} />
        <ModalDialogue open={open} handleClose={handleClose} />
        <Divider variant="middle" />
        <Line data={userData} options={options} style={{backgroundColor: '#cdcdcd'}} />
      </Box>
    </>
  );
}

export default App;

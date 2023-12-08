import * as React from 'react';
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Typography from '@mui/material/Typography';
import { CardActionArea } from '@mui/material';

export default function CardAuto() {
  return (
    <Card sx={{ maxWidth: 345 }}>
      <CardActionArea>
        <CardMedia
          component="img"
          height="140"
          image="/static/images/cards/contemplative-reptile.jpg"
          alt="auto"
        />
        <CardContent>
          <Typography gutterBottom variant="h5" component="div">
            Auto Azul
          </Typography>
          <Typography variant="body2" color="text.secondary">
            Aqui presentamos algunos de los moldes del 2017 que podrian hacer que tu travecia sea mas segura como los modelos del proximo año estan pos alir agencias estas apuradas pos movilizar sus inventacion es que podrias  ser el mejor momento para conseguir a mejores precios
          </Typography>
        </CardContent>
      </CardActionArea>
    </Card>
  );
}
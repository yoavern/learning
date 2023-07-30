#include "RecommendationSystem.h"

sp_movie
RecommendationSystem::add_movie (const std::string &name, int year, const
std::vector<double> &features)
{
  sp_movie movie = std::make_shared<Movie> (name, year);
  _movies[movie] = features;
  return movie;
}
sp_movie RecommendationSystem::recommend_by_content (const User &user)
{
  rank_map ranks = user.get_ranks ();
  decrease_average (ranks); // first step
  auto beg = _movies.begin ();
  std::vector<double> preference_v (_movies[beg->first].size (), 0.0);
  second_step (ranks, preference_v, _movies); // second step
  double best_similarity = LOWEST_SIM; // third step
  sp_movie best_movie;
  for (auto &movie: _movies)
  {
    if (ranks.find (movie.first) == ranks.end ())
    {
      double similarity = inner_products (preference_v, movie.second);
      similarity = similarity / ((double) norm (preference_v) * norm (movie
          .second));
      if (similarity > best_similarity)
      {
        best_similarity = similarity;
        best_movie = movie.first;
      }
    }
  }
  return best_movie;
}

bool compare_by_value (const std::pair<sp_movie, double> &pair1, const
std::pair<sp_movie, double> &pair2)
{
  return pair1.second > pair2.second;
}


void second_step (const rank_map &ranks, std::vector<double> &preference_v,
                  movie_map &movies)
{
  for (const auto &rank: ranks)
  { // for each movie (was ranked by user)
    for (int i = 0; i < (int)movies[rank.first].size (); ++i)
    {
      preference_v[i] += rank.second * movies[rank.first][i];
    }
  }
}
void decrease_average (rank_map &ranks)
{
  double sum = 0.0;
  for (auto &rank: ranks)
  {
    sum += rank.second;
  }
  double average = sum / (double) ranks.size ();
  for (auto &rank: ranks)
  { // decrease average from each rank (was ranked by user)
    rank.second -= average;
  }
}
double inner_products (const std::vector<double> &v1, const
std::vector<double> &v2)
{
  double sum = 0.0;
  for (int i = 0; i < (int)v1.size (); ++i)
  {
    sum += v1[i] * v2[i];
  }
  return sum;
}

double norm (const std::vector<double> &v)
{
  return sqrt (inner_products (v, v));
}

double
RecommendationSystem::predict_movie_score (const User &user, const sp_movie
&movie, int k)
{
  rank_map ranks = user.get_ranks ();
  similar_vector sim;
  for (const auto &rank: ranks)
  {
    double formula = inner_products (_movies[movie], _movies[rank.first]);
    formula = formula /( (double) norm (_movies[movie]) * (double) norm
        (_movies[rank.first]));
    sim.emplace_back(rank.first, formula);
  }
  std::sort (sim.begin (), sim.end (), compare_by_value);
  int i = 0;
  double mone=0.0, mechane=0.0;
  for (auto it = sim.begin (); i < k && it != sim.end (); ++i)
  {
    mone += it->second * ranks[it->first];
    mechane += it->second;
    ++it;
  }
  double return_value = (double)(mone / mechane);
  return return_value;
}

sp_movie RecommendationSystem::recommend_by_cf (const User &user, int k)
{
  sp_movie best_movie = _movies.begin ()->first;
  double best_similarity = predict_movie_score (user, _movies.begin ()
    ->first,k);
  for (const auto &movie : _movies)
  {
    if(user.get_ranks().find(movie.first) == user.get_ranks().end())
    {
      double similarity = predict_movie_score (user, movie.first, k);
      if (similarity > best_similarity)
      {
        best_similarity = similarity;
        best_movie = movie.first;
      }
    }
  }
  return best_movie;
}

sp_movie
RecommendationSystem::get_movie (const std::string &name, int year) const
{
  auto it = _movies.find (std::make_shared<Movie> (name, year));
  if (it != _movies.end ())
  {
    return it->first;
  }
  return nullptr;
}

std::ostream& operator<<(std::ostream& os, const RecommendationSystem& rs)
{
  for (const auto &movie: rs._movies)
  {
    os << *(movie.first);
  }
  return os;
}